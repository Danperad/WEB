<template>
  <div>
    <nav class="header">
      <h4>Dashboard</h4>
      <div class="navBarPanel">
        <input type="text" placeholder="Type here…" class="mr20">
        <div class="navigation">
          <button class="ExitBtn2" v-on:click="exitNavigation">
            <svg width="22" height="22" viewBox="0 0 22 22" fill="none"
                 xmlns="http://www.w3.org/2000/svg">
              <path d="M1 1L21 21M21 1L1 21" stroke="#FF0000"/>
            </svg>
          </button>
          <button class="NavBtn df">
            <img src="../assets/Shape.svg" alt="SignIn" class="mrNav">
            <h4 class="mr10">Sign In</h4>
          </button>
          <button class="NavBtn df">
            <img src="../assets/cog.svg" alt="cog" class="mrNav">
            <h4 class="mr10">Setting</h4>
          </button>
          <button class="NavBtn df">
            <img src="../assets/bell.svg" alt="bell" class="mrNav">
            <h4 class="mr10">New</h4>
          </button>
        </div>
        <button class="Person" v-on:click="openNavigation">
          <img src="../assets/Person.svg" alt="Person">
        </button>
      </div>
    </nav>
  </div>
</template>

<script lang='ts'>
import {defineComponent} from "vue";

export default defineComponent({
  name: 'Header',
  methods: {
    openNavigation() {
      const navigation: HTMLDivElement = document.getElementById('navigation') as HTMLDivElement;
      navigation.style.transform = 'translateX(0%)';
      navigation.style.opacity = '1';
    },
    exitNavigation() {
      const navigation: HTMLDivElement = document.getElementById('.navigation') as HTMLDivElement;
      navigation.style.transform = 'translateX(100%)';
      navigation.style.opacity = '0';
    },
  },
});
</script>

<style scoped>
.header {
  max-width: 96%;
  display: flex;
  margin: 0 auto;
  justify-content: space-between;
  color: white;
}

.navBarPanel {
  display: flex;
}

.navigation {
  display: flex;
  margin-top: 5px;
}

.mr20 {
  margin-right: 20px;
}

.mrNav {
  margin: 3px 3px 0 0;
}

.NavBtn {
  height: 30px;
  margin-top: 12px;
  border: none;
  cursor: pointer;
  background: none;
}

.df {
  display: flex;
}

.navBarPanel input {
  width: 120px;
  height: 24px;
  margin-top: 16px;
  background: url(../assets/Search.svg) no-repeat;
  background-size: auto 50%;
  background-position-y: 7px;
  background-position-x: 4px;
  padding-left: 30px;
  border: 0.5px solid rgba(226, 232, 240, 0.3);
  border-radius: 10px;
}

.navBarPanel h4 {
  font-size: 16px;
  color: #67748E;
  margin: 2px 0 0 0;
}

.Person {
  width: 30px;
  height: 30px;
  cursor: pointer;
  border: none;
  margin-top: 13px;
  margin-left: 5%;
  display: none;
  background: none;
  padding: 0;
}

.ExitBtn2 {
  display: none;
  border: none;
  background: none;
}

@media (max-width: 420px) {
  nav h4:nth-child(1) {
    display: none;
  }

  .mrNav {
    width: 40px;
    height: 40px;
  }

  .navBarPanel h4 {
    font-size: 30px;
    margin-left: 10px;
    margin-top: 4px;
  }

  .NavBtn {
    margin-top: 8%;
  }

  .navBarPanel {
    display: flex;
    margin: auto;
  }

  .navBarPanel input {
    margin-top: 10px;
    margin-bottom: 20px;
    height: 30px;
  }

  .Person {
    display: block;
  }

  .navigation {
    position: fixed;
    right: 0;
    top: 0;
    width: 100%;
    height: 100%;
    z-index: 9;
    transition: transform 0.2s, opacity 0.2s;
    transform: translateX(100%);
    opacity: 0;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    background: linear-gradient(111.84deg, rgba(6, 11, 38, 0.94) 59.3%, rgba(26, 31, 55, 0) 100%);
    backdrop-filter: blur(120px);
  }

  .ExitBtn2 {
    display: block;
  }
}
</style>
