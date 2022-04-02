<template>
  <div>
    <iframe :srcdoc="result" class="vyatsu-fr" id="vyatsu-fr"></iframe>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import axios from "axios";

const url = '/vyatsu/admission/';

export default defineComponent({
  name: 'Vyatsu',
  data() {
    return {
      result: [],
    };
  },
  mounted() {
    axios.get(url).then(
        (res) => {
          this.result = res.data;
        },
    );
  }
});
</script>

<style>
.vyatsu-fr {
  width: 100%;
  height: 600px;
}
</style>
