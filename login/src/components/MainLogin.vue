<template>
  <div class="container">
    <div>
      <img v-if="width > 600" src="../assets/big_login.jpg" alt="#" class="big-img">
      <img v-else src="../assets/small_login.jpg" alt="#" class="small-img">
    </div>
    <div>
      <input type="button" v-on:click="changeLogin" value="Авторизация" id="change-login-btn">
      <Login v-if="login"></Login>
      <Registration v-if="!login"></Registration>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

import Login from './Login.vue';
import Registration from './Registration.vue';

export default defineComponent({
  name: 'MainLogin',
  data() {
    return {
      login: false,
      width: 0,
    };
  },
  components: {
    Login,
    Registration
  },
  methods: {
    updateWidth() {
      this.width = window.innerWidth;
    },
    changeLogin() {
      const btn = document.getElementById("change-login-btn") as HTMLInputElement;
      this.login = !this.login;
      if (this.login){
        btn.value = "Регистрация";
      } else {
        btn.value = "Авторизация";
      }
    },
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
</style>
