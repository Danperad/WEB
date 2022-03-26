<template>
  <div>
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301" hidden></FioTemplate>
    <Vyatsu hidden></Vyatsu>
    <MainLogin hidden></MainLogin>
    <Dashboard></Dashboard>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import FioTemplate from '../../fiotemplate/src/main';
import Vyatsu from '../../vyatsu/src/main';
import MainLogin from '../../login/src/main';
import Dashboard from '../../dashboard/src/main';

export default defineComponent({
  name: 'App',
  components: {
    FioTemplate,
    Vyatsu,
    MainLogin,
    Dashboard
  },
});
</script>
