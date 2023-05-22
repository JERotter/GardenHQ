<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <v-app>

    <v-navigation-drawer
        v-model="drawer"
        floating
        permanent
      >
        <v-list
          density="compact"
          nav
        >
        <!-- https://www.youtube.com/watch?v=CjXgoYo86yY&t=1357s&ab_channel=MakeAppswithDanny -->
          <v-list-item prepend-icon="mdi-view-dashboard" title="Dashboard" value="home" to="/dashboard" link ></v-list-item>
          <!-- <v-list-item prepend-icon="mdi-newspaper" title="Tasks" value="about" to="/tasks" link ></v-list-item> -->
          <v-list-item prepend-icon="mdi-account-multiple" title="Users" value="about" to="/users" link ></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <v-app-bar
          color="teal-darken-4"
          image="../assets/images/vegetables.jpeg "  >
          <template v-slot:image>
            <v-img
              gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
            ></v-img>
          </template>
          <v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>
  
          <v-app-bar-title>Tasks</v-app-bar-title>
  
          <v-spacer></v-spacer>
  
          <v-btn icon to="/dashboard" link >
            <v-icon>mdi-view-dashboard</v-icon>
          </v-btn>
        </v-app-bar>

    <v-main>
      <div class="pa-6">
        <v-table theme="light">
          <thead>
            <tr>
              <th class="text-left">Id</th>
              <th class="text-left">Title</th>
              <th class="text-left">Start Date</th>
              <th class="text-left">Priority</th>
              <th class="text-left">Completed?</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="task in tasks" :key="task.id">
              <td>{{ task.abbreviatedId }}</td>
              <td>{{ task.title }}</td>
              <td>{{ task.createdOn }}</td>
              <td>{{ task.priority }}</td>
              <td>{{ task.completed }}</td>
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
import { useTasksStore } from '@/store/tasks.js';

export default {
  components: {
    footbar
  },
  created() {
    const tasksStore = useTasksStore();
    tasksStore.fetchTasks();
  },
  computed: {
    tasks() {
      const tasksStore = useTasksStore();
      return tasksStore.tasks;
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
//     axios.get("https://localhost:7135/api/GardenTask/tasks").then((res) => {
//       this.tasks = res.data;
//       console.log(this.tasks);
//     });
//   },
//   data() {
//     return {
//       tasks: [],
//       drawer: null
//     };
//   },
// };
</script>
