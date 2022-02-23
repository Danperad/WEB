<template>
  <div>
    <Vyatsu></Vyatsu>
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301"></FioTemplate>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import Vyatsu from '../../vyatsu/src/main';
import FioTemplate from '../../fiotemplate/src/main';

export default defineComponent({
  name: 'App',
  components: {
    Vyatsu,
    FioTemplate,
  },
});
</script>
