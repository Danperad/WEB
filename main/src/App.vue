<template>
  <div id="app">
    <FioTemplate last-name="Кокорин" first-name="Егор" middle-name="Дмитриевич"
                 group="ИТб-2301"></FioTemplate>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import FioTemplate from '../../fiotemplate/src/main';

@Component({
  components: {
    FioTemplate,
  },
})
export default class App extends Vue {
}
</script>
