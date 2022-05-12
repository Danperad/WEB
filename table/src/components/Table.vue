<template>
  <div class="conteiner">
    <loader v-if="loading"/>
    <table v-else>
      <tr>
        <th>id</th>
        <th>Пол</th>
        <th>Фамилия</th>
        <th>Имя</th>
        <th>Отчество</th>
        <th>Возраст</th>
        <th>Почта</th>
      </tr>
      <tr v-on:click="findById(item.ID)" v-for="(item) in list" :key="item.ID">
        <td>{{ item.ID }}</td>
        <td>
          <font-awesome-icon v-if="item.Gender === 1" icon="mars"/>
          <font-awesome-icon v-else icon="venus"/>
        </td>
        <td>{{ item.LastName }}</td>
        <td>{{ item.FirstName }}</td>
        <td>{{ item.MiddleName }}</td>
        <td>{{ item.Age }}</td>
        <td>
          {{ item.EMail }}
          <font-awesome-icon class="email-check" v-if="item.IsVerif" icon="check"/>
          <font-awesome-icon class="email-check" v-else icon="ban"/>
        </td>
      </tr>
    </table>
    <div id="openModal" class="modal">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h3 class="modal-title">Подробная информация</h3>
            <a v-on:click="closeModal" class="close">×</a>
          </div>
          <div class="modal-body">
            <p>ID: {{ element.ID }}</p>
            <div>
              <p>Пол:
                <font-awesome-icon v-if="element.Gender === 1" icon="mars"/>
                <font-awesome-icon v-else icon="venus"/>
              </p>
            </div>
            <p>Фамилия: {{ element.LastName }}</p>
            <p>Имя: {{ element.FirstName }}</p>
            <p>Отчество: {{ element.MiddleName }}</p>
            <p>Возраст: {{ element.Age }}</p>
            <div>
              <p>Email: {{ element.EMail }}
                <font-awesome-icon class="email-check" v-if="element.IsVerif" icon="check"/>
                <font-awesome-icon class="email-check" v-else icon="ban"/>
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import {library} from '@fortawesome/fontawesome-svg-core';
import {faMars, faVenus, faCheck, faBan} from "@fortawesome/free-solid-svg-icons";
import {FontAwesomeIcon} from '@fortawesome/vue-fontawesome';
import axios from "axios";

const url = 'api/getstud';
const headers = {
  'Content-Type': 'application/json',
};

library.add(faMars, faVenus, faCheck, faBan);

export default defineComponent({
  name: 'Table',
  components: {
    FontAwesomeIcon,
  },
  data: () => ({
    loading: true,
    list: [],
    element: {},
  }),
  mounted() {

  },
  unmounted() {

  },
  methods: {
    findById(i: Number) {
      axios.get(url + '?id=' + i, {headers})
        .then((response) => {
          console.log(response.data);
          this.element = response.data;
          const modal: HTMLDivElement = document.getElementById('openModal') as HTMLDivElement;
          modal.style.opacity = '1';
          modal.style.pointerEvents = 'auto';
          modal.style.overflowY = 'auto';
        })
        .catch((error) => {
          console.log(error);
        });
    },
    closeModal() {
      const modal: HTMLDivElement = document.getElementById('openModal') as HTMLDivElement;
      modal.style.opacity = '0';
      modal.style.pointerEvents = 'none';
    },
  },
});
</script>

<style scoped>
.conteiner {
  margin: 0 auto;
  text-align: center;
}

button {
  padding: 8px;
  background-color: #e8edff;
  border-radius: 4px;
  cursor: pointer;
  margin: 0 10px;
  color: #039;
  border-color: #039;
  font-size: 14px;
  font-weight: 600;
}

button:active {
  color: black;
  background-color: #039;
  border-color: black;
}

table {
  font-family: "Lucida Sans Unicode", "Lucida Grande", Sans-Serif, sans-serif;
  font-size: 14px;
  background: white;
  max-width: 70%;
  width: 70%;
  border-collapse: collapse;
  text-align: left;
  margin: 0 auto;
}

th {
  font-weight: normal;
  color: #039;
  border-bottom: 2px solid #6678b1;
  padding: 10px 8px;
}

td {
  color: #669;
  padding: 9px 8px;
  transition: .3s linear;
  border-bottom: 1px solid #ccc;
}

tr:hover td {
  background: #e8edff;
  cursor: pointer;
}

.modal {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  background: rgba(0, 0, 0, 0.5);
  z-index: 1050;
  opacity: 0;
  -webkit-transition: opacity 200ms ease-in;
  -moz-transition: opacity 200ms ease-in;
  transition: opacity 200ms ease-in;
  pointer-events: none;
  margin: 0;
  padding: 0;
}

.modal:target {
  opacity: 1;
  pointer-events: auto;
  overflow-y: auto;
}

.modal-dialog {
  position: relative;
  width: auto;
  margin: 10px;
}

@media (min-width: 576px) {
  .modal-dialog {
    max-width: 500px;
    margin: 30px auto;
  }
}

.modal-content {
  position: relative;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
  -webkit-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  background-color: #fff;
  -webkit-background-clip: padding-box;
  background-clip: padding-box;
  border: 1px solid rgba(0, 0, 0, .2);
  border-radius: .3rem;
  outline: 0;
}

@media (min-width: 768px) {
  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, .5);
    box-shadow: 0 5px 15px rgba(0, 0, 0, .5);
  }
}

.modal-header {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -webkit-align-items: center;
  -ms-flex-align: center;
  align-items: center;
  -webkit-box-pack: justify;
  -webkit-justify-content: space-between;
  -ms-flex-pack: justify;
  justify-content: space-between;
  padding: 15px;
  border-bottom: 1px solid #eceeef;
}

.modal-title {
  margin-top: 0;
  margin-bottom: 0;
  line-height: 1.5;
  font-size: 1.25rem;
  font-weight: 500;
}

.close {
  float: right;
  font-family: sans-serif;
  font-size: 24px;
  font-weight: 700;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: .5;
  text-decoration: none;
}

.close:focus, .close:hover {
  color: #000;
  text-decoration: none;
  cursor: pointer;
  opacity: .75;
}

.modal-body {
  margin-left: 10px;
  text-align: left;
}

.email-check {
  margin-bottom: 2px
}
</style>
