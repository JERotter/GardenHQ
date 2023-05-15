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
        <v-list-item prepend-icon="mdi-view-dashboard" title="Dashboard" value="home" to="/dashboard" link ></v-list-item>
        <v-list-item prepend-icon="mdi-forum" title="Tasks" value="about" to="/tasks" link ></v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar>
      <v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>

      <v-toolbar-title>Application</v-toolbar-title>
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





<!-- <v-navigation-drawer v-model="drawer"> -->
