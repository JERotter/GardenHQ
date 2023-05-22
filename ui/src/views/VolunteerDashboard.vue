<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <v-app id="inspire">
    <v-navigation-drawer v-model="drawer" floating permanent left app>
      <v-list density="compact" nav>
        <!-- https://www.youtube.com/watch?v=CjXgoYo86yY&t=1357s&ab_channel=MakeAppswithDanny -->
        <!-- <v-list-item prepend-icon="mdi-view-dashboard" title="Dashboard" value="home" to="/dashboard" link ></v-list-item> -->
        <v-list-item
          prepend-icon="mdi-newspaper"
          title="Tasks"
          value="about"
          to="/tasks"
          link
        ></v-list-item>
        <v-list-item
          prepend-icon="mdi-folder"
          title="Team"
          value="about"
          to=" "
          link
        ></v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar color="teal-darken-4" image="../assets/images/vegetables.jpeg " >
      <template v-slot:image>
        <v-img
          gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
        ></v-img>
      </template>
      <v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>

      <v-app-bar-title>Volunteer </v-app-bar-title>

      <v-spacer></v-spacer>

      <v-btn icon to="/" link>
        <v-icon>mdi-logout</v-icon>
      </v-btn>
    </v-app-bar>

    <v-main >
      <div class="main" >
        <dashboardInvites />
        <dashboardInvites />
        <dashboardInvites />
      </div>
    </v-main>
    <footbar />
  </v-app>
</template>

<script>
import dashboardInvites from "../components/DashboardInvites.vue";
// import dashboarditem2 from "../components/DashboardItem2.vue";
import footbar from "../components/Footer.vue";

export default {
  components: { dashboardInvites, footbar },
  data: () => ({
    drawer: null,
  }),
};
</script>

<style lang="scss" scoped>
.card-list {
  --v-card-list-gap: 1.5rem;
}

.main {
  padding: 25px;
  grid-area: main;
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-template-rows: 1fr 1fr 1fr;
  gap: 20px;
}
</style>
<!-- :style="{ marginLeft: drawer ? '0px' : '0' }" -->
<!-- margin: left drawer ? '300px' : '0' -->
