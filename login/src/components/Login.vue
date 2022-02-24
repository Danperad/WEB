<template>
  <div class="container">
    <div>
      <img v-if="width > 600" src="../assets/big_login.jpg" alt="#" class="big-img">
      <img v-else src="../assets/small_login.jpg" alt="#" class="small-img">
    </div>
    <div class="login-text">
      <h1>Авторизация</h1>
      <div v-if="width > 600">
        <div>
          <p>Логин</p>
          <input type="text">
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
        <input type="text" placeholder="Логин">
        <div class="password">
          <input type="password" id="pass-mobile" placeholder="Пароль">
          <button v-on:click="changePassVis" id="password-mobile"
                  class="password-control"></button>
        </div>
      </div>
      <div>
        <input type="button" value="Войти" class="login-btn">
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';

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

<style>
.small-img {
  height: 150px;
  margin: 0 auto;
  display: block;
}

.big-img {
  height: 300px;
  margin-right: 30px;
}

.container {
  width: 100%;
  margin: 0 auto;
  display: flex;
  justify-content: center;
}

@media (max-width: 600px) {
  .container {
    display: block;
  }
}

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

.login-text input[type="text"], input[type="password"] {
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
