<template>
  <div>
    <div>
      <p>E-Mail</p>
      <input type="text" id="reg-email">
    </div>
    <div>
      <p>Логин</p>
      <input type="text" id="reg-login">
    </div>
    <div>
      <p>Пароль</p>
      <input type="password" id="reg-pass">
    </div>
    <div>
      <p>Повторите пароль</p>
      <input type="password" id="reg-rep-pass">
    </div>
    <div>
      <input type="button" value="Регистрация">
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';

export default defineComponent({
  name: 'Registration',
  methods:{
    regClick: function (){
      let email = (document.getElementById('reg-email') as HTMLInputElement).value;
      let login = (document.getElementById('reg-login') as HTMLInputElement).value;
      let pass = (document.getElementById('reg-pass') as HTMLInputElement).value;
      let pass2 = (document.getElementById('reg-rep-pass') as HTMLInputElement).value;
      if (email.length === 0) {
        alert("Введите E-Mail");
        return;
      }
      if (login.length < 6 || pass.length < 8) {
        alert("Длинна логина или пароля < 6")
        return;
      }
      if (pass !== pass2) {
        alert("Пароли не совпадают");
        return;
      }
    }
  }
});
</script>

<style scoped>

</style>
