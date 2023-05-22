<template>
  <v-app>
    <v-navigation-drawer v-model="drawer" floating permanent>
      <v-list density="compact" nav>
        <!-- https://www.youtube.com/watch?v=CjXgoYo86yY&t=1357s&ab_channel=MakeAppswithDanny -->
        <v-list-item
          prepend-icon="mdi-view-dashboard"
          title="Dashboard"
          value="home"
          to="/dashboard"
          link
        ></v-list-item>
        <v-list-item
          prepend-icon="mdi-newspaper"
          title="Tasks"
          value="about"
          to="/tasks"
          link
        ></v-list-item>
        <!-- <v-list-item prepend-icon="mdi-account-multiple" title="Users" value="about" to="/users" link ></v-list-item> -->
      </v-list>
    </v-navigation-drawer>

    <v-app-bar color="teal-darken-4" image="../assets/images/vegetables.jpeg ">
      <template v-slot:image>
        <v-img
          gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
        ></v-img>
      </template>
      <v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>

      <v-app-bar-title>Users</v-app-bar-title>

      <v-spacer></v-spacer>

      <v-btn icon to="/dashboard" link>
        <v-icon>mdi-view-dashboard</v-icon>
      </v-btn>
    </v-app-bar>
    <v-main>
      <div class="pa-6">
        <v-table theme="light">
          <thead>
            <tr>
              <th class="text-left">Id</th>
              <th class="text-left">First Name</th>
              <th class="text-left">Last Name</th>
              <th class="text-left">Role</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="user in users" :key="user.id">
              <td>{{ user.abbreviatedId }}</td>
              <td>{{ user.firstName }}</td>
              <td>{{ user.lastName }}</td>
              <td>{{ user.type }}</td>
            </tr>
          </tbody>
        </v-table>
      </div>
    </v-main>
    <footbar />
  </v-app>
</template>

<script>
import footbar from "../components/Footer.vue";
import { useUsersStore } from '@/store/users.js';

export default {
  components: {
    footbar
  },
  created() {
    const usersStore = useUsersStore();
    usersStore.fetchUsers();
  },
  computed: {
    users() {
      const usersStore = useUsersStore();
      return usersStore.users;
    }
  },
  data() {
    return {
      drawer: null
    };
  },
};
//WITHOUT Pinia://
// import axios from "axios";
// import footbar from "../components/Footer.vue";

// export default {
//   components: { footbar },

//   mounted() {
//     axios.get("https://localhost:7135/api/Users/Users").then((res) => {
//       this.users = res.data;
//       console.log(this.users);
//     });
//   },
//   data() {
//     return {
//       users: [],
//       drawer: null
//     };
//   },
// };
</script>
