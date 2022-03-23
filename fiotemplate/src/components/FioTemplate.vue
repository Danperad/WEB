<template>
  <div class="fio">
    <p>{{lastName}} {{firstName}} {{middleName}}, {{group}}</p>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'FioTemplate',
  props: {
    lastName: String,
    firstName: String,
    middleName: String,
    group: String,
  },
});
</script>

<style scoped>
  .fio{
    text-align: center;
  }
</style>
