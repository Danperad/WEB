<template>
  <div class="fio-template">
    <p>{{lastName}} {{firstName}} {{middleName}}, {{group}}</p>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class FioTemplate extends Vue {
  @Prop() private lastName!: string;

  @Prop() private firstName!: string;

  @Prop() private middleName!: string;

  @Prop() private group!: string;
}
</script>

<style scoped>
  .fio-template{
    text-align: center;
  }
</style>
