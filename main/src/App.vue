<template>
  <div>
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301"></FioTemplate>
    <Vyatsu></Vyatsu>
    <Login></Login>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import FioTemplate from '../../fiotemplate/src/main';
import Vyatsu from '../../vyatsu/src/main';
import Login from '../../login/src/main';

export default defineComponent({
  name: 'App',
  components: {
    FioTemplate,
    Vyatsu,
    Login,
  },
});
</script>
