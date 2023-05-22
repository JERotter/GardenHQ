<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <v-app id="inspire">
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
        <!-- <v-list-item prepend-icon="mdi-view-dashboard" title="Dashboard" value="home" to="/dashboard" link ></v-list-item> -->
        <v-list-item prepend-icon="mdi-newspaper" title="Tasks" value="about" to="/tasks" link ></v-list-item>
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

        <v-app-bar-title>Welcome, Admin!</v-app-bar-title>

        <v-spacer></v-spacer>

        <v-btn icon to="/dashboard" link >
          <v-icon>mdi-view-dashboard</v-icon>
        </v-btn>
      </v-app-bar>

    <v-main>
      <!--  -->
    </v-main>
  </v-app>
</template>

<script>
  export default {
    data: () => ({ drawer: null }),
  }
</script>