<template>
  <v-app>
    <v-app-bar
      color="teal-darken-4"
      image="https://picsum.photos/id/189/1920/1080 "
    >
      <template v-slot:image>
        <v-img
          gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
        ></v-img>
      </template>

      <!-- <template v-slot:prepend>
            <v-app-bar-nav-icon></v-app-bar-nav-icon>
          </template> -->

      <v-app-bar-title>Users</v-app-bar-title>

      <!-- <v-spacer></v-spacer> -->

      <!-- <v-btn icon>
            <v-icon>mdi-magnify</v-icon>
          </v-btn> -->

      <v-btn icon to="/dashboard" link>
        <v-icon>mdi-view-dashboard</v-icon>
      </v-btn>

      <!-- <v-btn icon>
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn> -->
    </v-app-bar>
    <div class="pa-6">
      <v-table theme="light">
        <thead>
          <tr>
            <th class="text-left">Name</th>
            <th class="text-left">Team</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in desserts" :key="item.name">
            <td>{{ item.name }}</td>
            <td>{{ item.team }}</td>
          </tr>
        </tbody>
      </v-table>
    </div>
  </v-app>
</template>

<script>
export default {
  data() {
    return {
      desserts: [
        {
          name: "Frozen Yogurt",
          team: "Supplies",
        },
        {
          name: "Ice cream sandwich",
          team: 237,
        },
        {
          name: "Eclair",
          team: 262,
        },
        {
          name: "Cupcake",
          team: 305,
        },
        {
          name: "Gingerbread",
          team: 356,
        },
        {
          name: "Jelly bean",
          team: 375,
        },
        {
          name: "Lollipop",
          team: 392,
        },
        {
          name: "Honeycomb",
          team: 408,
        },
        {
          name: "Donut",
          team: 452,
        },
        {
          name: "KitKat",
          team: 518,
        },
      ],
    };
  },
};
</script>
