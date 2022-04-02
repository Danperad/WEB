<template>
  <div class="reg-text">
    <h1>Регистрация</h1>
    <div class="reg-div">
      <p v-if="!isMobile">EMail</p>
      <input type="email" id="reg-email">

      <p v-if="!isMobile">Логин</p>
      <input type="text" id="reg-login" v-model="data.login">

      <p v-if="!isMobile">Пароль</p>
      <div class="password">
        <input type="password" id="reg-pass">
        <button v-on:click="changePassVis" id="password"
                class="password-control"></button>
      </div>

      <p v-if="!isMobile">Повторите пароль</p>
      <input type="password" id="reg-pass2">
    </div>
    <div>
      <input type="button" value="Регистрация" class="reg-btn" v-on:click="regClick">
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import axios from "axios";

export default defineComponent({
  name: 'Registration',
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
      const email = document.getElementById("reg-email") as HTMLInputElement;
      const login = document.getElementById("reg-login") as HTMLInputElement;
      const pass = document.getElementById("reg-pass") as HTMLInputElement;
      const pass2 = document.getElementById("reg-pass2") as HTMLInputElement;
      if (this.isMobile) {
        email.placeholder = "EMail";
        login.placeholder = "Логин";
        pass.placeholder = "Пароль";
        pass2.placeholder = "Повторите пароль";
      } else {
        email.placeholder = "";
        login.placeholder = "";
        pass.placeholder = "";
        pass2.placeholder = "";
      }
    },
    changePassVis() {
      this.hide = !this.hide;
      let pass: HTMLInputElement;
      let btn: HTMLButtonElement;
      pass = document.getElementById("reg-pass") as HTMLInputElement;
      btn = document.getElementById("password") as HTMLButtonElement;
      if (this.hide) {
        pass.type = "password";
        btn.style.background = "url(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat";
      } else {
        pass.type = "text";
        btn.style.background = "url(https://snipp.ru/demo/495/no-view.svg) 0 0 no-repeat";
      }
    },
    regClick: function () {
      let email = (document.getElementById('reg-email') as HTMLInputElement).value;
      let login = (document.getElementById('reg-login') as HTMLInputElement).value;
      let pass = (document.getElementById('reg-pass') as HTMLInputElement).value;
      let pass2 = (document.getElementById('reg-pass2') as HTMLInputElement).value;
      if (email.length === 0) {
        alert("Введите E-Mail");
        return;
      }
      if (login.length < 6) {
        alert("Длинна логина должна быть больше 5")
        return;
      }
      if (pass.length < 8) {
        alert("Длинна пароля должна быть больше 7")
        return;
      }
      if (pass !== pass2) {
        alert("Пароли не совпадают");
        return;
      }
      const headers = {
        'Content-Type': 'application/json',
      };
      const url = 'api/auth/check';
      axios.post(url, this.data, {headers})
        .then(
          (res: any) => {
            if (res.data.IsValid) alert("Регистрация прошла успешно");
            else alert("Данный логин уже занят");

          },
        ).catch(
        (err: any) => {
          alert("Сервер не доступен");
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

.reg-text {
  display: flex;
  align-items: center;
  flex-direction: column;
}

.reg-text p {
  font-family: SansSerif, sans-serif;
  margin-top: 5px;
  margin-bottom: 5px;
}

.reg-text input[type="text"], .reg-text input[type="password"], .reg-text input[type="email"] {
  border-radius: 5px;
  border-width: thin;
  font-size: medium;
  padding: 3px 7px;
}

.reg-btn {
  margin-top: 5px;
  padding: 7px 23px;
  border-radius: 15px;
  border-width: thin;
  font-size: 16px;
  color: white;
  cursor: pointer;
  background-color: blueviolet;
}

.reg-div{
  margin: 0 auto;
  display: flex;
  flex-direction: column;
}

.reg-div input {
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
