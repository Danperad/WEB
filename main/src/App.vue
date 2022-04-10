<template>
  <div>
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301" hidden></FioTemplate>
    <Vyatsu hidden></Vyatsu>
    <MainLogin hidden></MainLogin>
    <MainDashboard class="container"></MainDashboard>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import FioTemplate from '../../fiotemplate/src/main';
import Vyatsu from '../../vyatsu/src/main';
import MainLogin from '../../login/src/main';
import MainDashboard from '../../dashboard/src/main';

export default defineComponent({
  name: 'App',
  components: {
    FioTemplate,
    Vyatsu,
    MainLogin,
    MainDashboard,
  },
});
</script>

<style scoped>
.container {
  display: flex;
  width: 100%;
  background-color: #060B26;
  background-size: 100% 100%;
  background-image: url(./assets/bg2.png);
  font-family: 'Lato', sans-serif;
}
</style>
