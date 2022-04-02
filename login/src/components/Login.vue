<template>
  <div class="login-text">
    <h1>Авторизация</h1>
    <div class="login-div">
      <p v-if="!isMobile">Логин</p>
      <input type="text" id="login" v-model="data.login">

      <p v-if="!isMobile">Пароль</p>
      <div class="password">
        <input type="password" id="pass" v-model="data.pass">
        <button v-on:click="changePassVis" id="password"
                class="password-control"></button>
      </div>
    </div>
    <div>
      <input type="button" value="Войти" class="login-btn" v-on:click="check">
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import axios from 'axios';

export default defineComponent({
  name: 'Login',
  data() {
    return {
      isMobile: false,
      width: 0,
      hide: true,
      data: {}
    };
  },
  methods: {
    updateWidth() {
      this.width = window.innerWidth;
      this.isMobile = this.width <= 600;
      const login = document.getElementById("login") as HTMLInputElement;
      const pass = document.getElementById("pass") as HTMLInputElement;
      if (this.isMobile) {
        login.placeholder = "Логин";
        pass.placeholder = "Пароль";
      } else {
        login.placeholder = "";
        pass.placeholder = "";
      }
    },
    changePassVis() {
      this.hide = !this.hide;
      let pass: HTMLInputElement;
      let btn: HTMLButtonElement;
      pass = document.getElementById("pass") as HTMLInputElement;
      btn = document.getElementById("password") as HTMLButtonElement;
      if (this.hide) {
        pass.type = "password";
        btn.style.background = "url(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat";
      } else {
        pass.type = "text";
        btn.style.background = "url(https://snipp.ru/demo/495/no-view.svg) 0 0 no-repeat";
      }
    },
    check() {
      const headers = {
          'Content-Type': 'application/json',
      };
      const url = 'api/auth/signin';
      axios.post(url, this.data, {headers})
        .then(
          (res: any) => {
            if(res.data.IsValid) alert("Авторизация прошла успешно");
            else alert("Неверный логин или пароль");
          },
        ).catch(
        (err: any) => {
          alert("Сервер недоступен");
        },
      );
    }
  },
  created() {
    this.width = window.innerWidth;
    window.addEventListener('resize', this.updateWidth);
  },
  mounted() {
    this.updateWidth();
  },
  unmounted() {
    window.removeEventListener('resize', this.updateWidth)
  }
});
</script>

<style scoped>

.login-btn {
  margin-top: 5px;
  padding: 7px 23px;
  border-radius: 15px;
  border-width: thin;
  font-size: 16px;
  color: white;
  cursor: pointer;
  background-color: blueviolet;
}

.login-text {
  display: flex;
  align-items: center;
  flex-direction: column;
}

.login-text p {
  font-family: SansSerif, sans-serif;
  margin-top: 5px;
  margin-bottom: 5px;
}

.login-text input[type="text"], .login-text input[type="password"] {
  border-radius: 5px;
  border-width: thin;
  font-size: medium;
  padding: 3px 7px;
}

.login-div input {
  margin-top: 5px;
  margin-bottom: 5px;
}

.password {
  text-align: center;
  position: relative;
}

.password-control {
  position: absolute;
  top: 8px;
  right: 6px;
  display: inline-block;
  width: 20px;
  height: 20px;
  background: url(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat;
  border: 0;
}
</style>
