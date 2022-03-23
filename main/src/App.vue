<template>
  <div>
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301"></FioTemplate>
    <Vyatsu hidden></Vyatsu>
    <MainLogin></MainLogin>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import FioTemplate from '../../fiotemplate/src/main';
import Vyatsu from '../../vyatsu/src/main';
import MainLogin from '../../login/src/main';

export default defineComponent({
  name: 'App',
  data() {
    return {
      yes: false,
    };
  },
  components: {
    FioTemplate,
    Vyatsu,
    MainLogin,
  },
});
</script>
