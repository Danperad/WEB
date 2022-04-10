<template>
  <div>
    <button class="menu-btn" v-on:click="openNavbarPanel">
      <svg width="50" height="32" viewBox="0 0 50 32" fill="none"
           xmlns="http://www.w3.org/2000/svg">
        <g clip-path="url(#clip0_101_2)">
          <rect width="50" height="32" fill="#060B26"/>
          <rect y="1" width="50" height="6" rx="3" fill="#0075FF"/>
          <rect y="13" width="50" height="6" rx="3" fill="#0075FF"/>
          <rect y="25" width="50" height="6" rx="3" fill="#0075FF"/>
        </g>
        <defs>
          <clipPath id="clip0_101_2">
            <rect width="50" height="32" fill="white"/>
          </clipPath>
        </defs>
      </svg>
    </button>
    <div class="navbar-panel">
      <header>
        <div class="block">
          <img src="../assets/Logo.svg" alt="logo" class="m0 logo">
          <img src="../assets/Vector.svg" alt="Vector" class="Vector">
        </div>
        <button class="ExitBtn" v-on:click="exitNavbarPanel">
          <svg width="22" height="22" viewBox="0 0 22 22" fill="none"
               xmlns="http://www.w3.org/2000/svg">
            <path d="M1 1L21 21M21 1L1 21" stroke="#FF0000"/>
          </svg>
        </button>
      </header>
      <main>
        <ul>
          <li class="BGW-li">
            <button type="button" class="btnCheck" id="Dashboard" href="#">
              <img src="../assets/home.svg" alt="shop" class="bgp mr20">
              <h4 class="m0">Dashboard</h4>
            </button>
          </li>
          <li>
            <button type="button" class="btnUncheck" id="Tables" v-on:click="clickSideBar">
              <img src="../assets/chart.svg" alt="office" class="bgw mr20">
              <h4 class="m0">Tables</h4>
            </button>
          </li>
          <li>
            <button type="button" class="btnUncheck" id="Billing" v-on:click="clickSideBar">
              <img src="../assets/card.svg" alt="credit" class="bgw mr20">
              <h4 class="m0">Billing</h4>
            </button>
          </li>
          <li>
            <button type="button" class="btnUncheck" id="RTL" v-on:click="clickSideBar">
              <img src="../assets/setting.svg" alt="settings" class="bgw mr20">
              <h4 class="m0">RTL</h4>
            </button>
          </li>
          <li>
            <h4 class="tittle">ACCOUNT PAGES</h4>
          </li>
          <li>
            <button type="button" class="btnUncheck">
              <img src="../assets/profile.svg" alt="Profile" class="bgw mr20">
              <h4 class="m0">Profile</h4>
            </button>
          </li>
          <li>
            <button type="button" class="btnUncheck">
              <img src="../assets/doc.svg" alt="document" class="bgw mr20">
              <h4 class="m0">Sign In</h4>
            </button>
          </li>
          <li>
            <button type="button" class="btnUncheck">
              <img src="../assets/rocket.svg" alt="spaceship" class="bgw mr20">
              <h4 class="m0">Sign Up</h4>
            </button>
          </li>
        </ul>
      </main>
    </div>
  </div>
</template>

<script lang='ts'>
import {defineComponent} from "vue";

export default defineComponent({
  name: 'Sidebar',
  methods: {
    openNavbarPanel() {
      const NavbarPanel: HTMLDivElement = document.getElementById('.navbar-panel') as HTMLDivElement;
      NavbarPanel.style.transform = 'translateX(0%)';
      NavbarPanel.style.opacity = '1';
    },
    exitNavbarPanel() {
      const NavbarPanel: HTMLDivElement = document.getElementById('.navbar-panel') as HTMLDivElement;
      NavbarPanel.style.transform = 'translateX(-100%)';
      NavbarPanel.style.opacity = '0';
    },
  },
});
</script>

<style scoped>
header {
  display: flex;
  margin-left: 40px;
}

header img {
  height: 30px;
  width: 30px;
}

.m0 {
  margin: 0;
}

.tittle {
  color: white;
}

.logo {
  width: 135px;
  height: 14px;
  margin: 36px 0 20px 0;
}

.Vector {
  width: 80%;
}

.block {
  display: block;
  margin: 0 auto;
}

main ul {
  list-style-type: none;
  padding-left: 20px;
}

main li {
  width: 80%;
  display: flex;
  align-items: center;
  padding: 10px 20px 10px 10px;
  border-radius: 8px;
}

main li button {
  width: 34px;
  padding: 0;
  background: none;
}

main li h4 {
  white-space: nowrap;
}

.BGW-li {
  background: #1A1F37;
  box-shadow: 0 3.5px 5.5px rgba(0, 0, 0, 0.02);
  border-radius: 15px;
}

.bgp {
  padding: 9px;
  background: #0075FF;
  border-radius: 12px;
}

.bgw {
  background: #1A1F37;
  box-shadow: 0 3.5px 5.5px rgba(0, 0, 0, 0.02);
  border-radius: 12px;
  padding: 9px;
}

.mr20 {
  margin-right: 20px;
}

.btnCheck {
  border: none;
  cursor: pointer;
  display: flex;
  align-items: center;
  font-size: 14px;
  color: #ffff;
}

.btnUncheck {
  border: none;
  cursor: pointer;
  display: flex;
  align-items: center;
  font-size: 14px;
  color: #ffff;
}

.menu-btn {
  display: none;
  margin-left: 10px;
  cursor: pointer;
  background-color: none;
  border: none;
  padding: 0;
  height: 32px;
}

.ExitBtn {
  display: none;
  border: none;
  background: none;
  margin-left: 10%;
  margin-right: 5%;
}

@media (max-width: 420px) {
  header {
    margin-left: 5%;
    margin-top: 14px;
  }

  .block {
    text-align: center;
  }

  main ul {
    padding-left: 5%;
  }

  main li {
    padding: 5px;
  }

  .BGW-li {
    background-color: #1A1F37;
  }

  .menu-btn {
    display: block;
  }

  .navbar-panel {
    position: fixed;
    right: 0;
    top: 0;
    width: 100%;
    height: 100%;
    z-index: 9;
    transition: transform 0.2s, opacity 0.2s;
    transform: translateX(-100%); /*убираем меню в сторону */
    opacity: 0;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    background: linear-gradient(111.84deg, rgba(6, 11, 38, 0.94) 59.3%, rgba(26, 31, 55, 0) 100%);
    backdrop-filter: blur(120px);
  }

  .ExitBtn {
    display: block;
  }
}
</style>
