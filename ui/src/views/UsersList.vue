<template>
  <v-app>
    <appbar/>
    <v-main>
    <div class="pa-6">
      <v-table theme="light">
        <thead>
          <tr>
            <th class="text-left">User Id</th>
            <th class="text-left">First Name</th>
            <th class="text-left">Last Name</th>
            <th class="text-left">Role</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="user in users.data" :key="user.id">
            <td>{{ user.id }}</td>
            <td>{{ user.firstName }}</td>
            <td>{{ user.lastName }}</td>
            <td>{{ user.type }}</td>
          </tr>
        </tbody>
      </v-table>
    </div>
  </v-main>
  <footbar/>
  </v-app>
</template>

<script>
import axios from "axios";
import appbar from '../components/Appbar.vue';
import footbar from '../components/Footer.vue';

export default {
  components: { appbar, footbar },

  mounted() {
    axios.get("https://localhost:7135/api/Users/Users").then((res) => {
      this.users = res.data;
      console.log(this.users);
    });
  },
  data() {
    return {
      users: [],
    };
  },
};
</script>






