<template>
  <div>
    <SideBar class="SideBar"/>
    <div class="block">
      <Header class="Header"/>
      <Dashboard class="Dashboard"/>
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from "vue";

import Header from './Header.vue';
import SideBar from './Sidebar.vue';
import Dashboard from './Dashboard.vue';

export default defineComponent({
  name: 'MainDashboard',
  components: {
    Header,
    SideBar,
    Dashboard,
  }
});

</script>

<style scoped>

.SideBar {
  width: 16%;
  margin: 10px;
  background: linear-gradient(111.84deg, rgba(6, 11, 38, 0.94) 59.3%, rgba(26, 31, 55, 0) 100%);
  backdrop-filter: blur(120px);
  border-radius: 20px;
}

.block {
  width: 84%;
}

.Header {
  width: 100%;
}

@media (max-width: 420px) {
  .SideBar {
    background: none;
    backdrop-filter: none;
  }
}
</style>
