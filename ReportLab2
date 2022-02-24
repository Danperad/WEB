<p align = center>МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>РОССИЙСКОЙ ФЕДЕРАЦИИ

<p align = center>ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>«ВЯТСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ»

<p align = center>Институт математики и информационных систем

<p align = center>Факультет автоматики и вычислительной техники

<p align = center>Кафедра систем автоматизации управления

<p align = right>Дата сдачи на проверку:

<p align = right>«___» __________ 2022 г.

<p align = right>Проверено:

<p align = right>«___» __________ 2022 г.

<p align = center>Отчет по лабораторной работе № 2

<p align = center>по дисциплине

<p align = center>«Web-программирование»

<p align = center>Вариант 2




<p align = center>Разработал студент гр. ИТб-2301-01-00 ________________ /Кокорин Е.Д./

<p align = center>Проверил ст. преподаватель _________________ /Земцов М.А./

<p align = center>Работа защищена с оценкой «___________» «___» __________ 2022 г.



<p align = center>Киров 2022

__________
Цель:  отобразить на странице адаптивный блок авторизации

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Отобразить блок авторизации на странице

Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Danperad/WEB)* на сайте github.com от ветки lab1 создана новая ветвь с названием lab2. Cоздан Vue проект c названием login. В этом проекте был добавлен компонент Login.vue.

2. Отобразить блок авторизации на странице

В ходе выполнения работы был реализован блок регистрации для компьютерной версии сайта, который содержит в себе: большой логоти, который распологается слева, название, два поля ввода для логина и пароля с кнопкой смены видимости. Отображаемый на странице блок авторизации представлен на рисунке 1.

<p align=center><img src="./Img/Lab2PC.png" alt="img-pc"></p>

<p align = center>Рисунок 1 – Блок регистрации для компьютерной версии сайта

Для мобильной версии сайта на странице присутствуют все те же компоненты, что и для компьютерной, но с некоторыми отличиями: маленький логотип, расположенный сверху, подсказки для полей ввода выполнены с помощью атрибута placeholder. Блок авторизации для мобильных устройств отображен на рисунке 2.


<p align=center><img src="./Img/Lab2Mobile.png" alt="img-mobil"></p>

<p align = center>Рисунок 2 – Блок регистрации для мобильной версии сайта

Листинг компонента Login.vue представлен в приложении А.

Вывод: в ходе лабораторной работы организовано рабочее пространство, закреплены навыки работы с веб-фреймворком VUE. Также были освежены знания языков разметки html и css. На практике реализован адаптивный блок авторизации.

<p align = center>2

__________

<p align = center>Приложение А

<p align = center>(обязательное) 

<p align = center>Листинг компонента Login.vue

```html
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
```

<p align = center>3
__________
```css
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
```
<p align = center>4
__________
```css
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
```