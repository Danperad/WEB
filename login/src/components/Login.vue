<template>
  <div>
    <div class="login-text">
      <h1>Авторизация</h1>
      <div v-if="width > 600">
        <div>
          <p>Логин</p>
          <input type="text" id="login-desktop">
        </div>
        <div>
          <p>Пароль</p>
          <div class="password">
            <input type="password" id="pass-desktop">
            <button v-on:click="changePassVis" id="password-desktop"
                    class="password-control"></button>
          </div>
        </div>
      </div>
      <div v-else class="mobile-login">
        <input type="text" placeholder="Логин" id="login-mobile">
        <div class="password">
          <input type="password" id="pass-mobile" placeholder="Пароль">
          <button v-on:click="changePassVis" id="password-mobile"
                  class="password-control"></button>
        </div>
      </div>
      <div>
        <input type="button" value="Войти" class="login-btn" v-on:click="check">
      </div>
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
      width: 0,
      hide: false,
    };
  },
  methods: {
    updateWidth() {
      this.width = window.innerWidth;
      this.changePassVis();
    },
    changePassVis() {
      this.hide = !this.hide;
      let pass: HTMLInputElement;
      let btn: HTMLButtonElement;
      if (this.width > 600) {
        pass = document.getElementById("pass-desktop") as HTMLInputElement;
        btn = document.getElementById("password-desktop") as HTMLButtonElement;
      } else {
        pass = document.getElementById("pass-mobile") as HTMLInputElement;
        btn = document.getElementById("password-mobile") as HTMLButtonElement;
      }
      if (this.hide) {
        pass.type = "password";
        btn.style.background = "url(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat";
      } else {
        pass.type = "text";
        btn.style.background = "url(https://snipp.ru/demo/495/no-view.svg) 0 0 no-repeat";
      }
    },
    check() {
      let login: HTMLInputElement;
      let pass: HTMLInputElement;
      if (this.width > 600) {
        login = document.getElementById("login-desktop") as HTMLInputElement;
        pass = document.getElementById("pass-desktop") as HTMLInputElement;
      } else {
        login = document.getElementById("login-mobile") as HTMLInputElement;
        pass = document.getElementById("pass-mobile") as HTMLInputElement;
      }
      const data = {
        "login": login.value,
        "password": pass.value
      };
      const url = 'https://203bdd99-4e82-47ae-ba4d-f0f74918bf95.mock.pstmn.io/auth/check'
      axios.post(url, data, {headers: {'Content-Type': 'application/json'}})
        .then(
          (res: any) => {
            console.log(res.data)
          },
        ).catch(
          (err: any) => {
            console.log(err)
          },
      );
    }
  },
  created() {
    this.width = window.innerWidth;
    window.addEventListener('resize', this.updateWidth);
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

.mobile-login input {
  margin-top: 5px;
  margin-bottom: 5px;
}

.password {
  text-align: center;
  position: relative;
}

.password-control {
  position: absolute;
  top: 3px;
  right: 6px;
  display: inline-block;
  width: 20px;
  height: 20px;
  background: url(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat;
  border: 0;
}

@media (max-width: 600px) {
  .password-control {
    top: 8px;
  }
}
</style>
