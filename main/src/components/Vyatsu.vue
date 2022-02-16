<template>
  <iframe :srcdoc="data" height="1080" width="1920"></iframe>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import axios from 'axios';

const url = 'http://127.0.0.1:8080/admission/';

@Component
export default class Vyatsu extends Vue {
  @Prop() private data!: [];

  mounted(): void {
    axios.get(url).then(
      (res) => {
        this.data = res.data;
      },
    );
  }
}
</script>
