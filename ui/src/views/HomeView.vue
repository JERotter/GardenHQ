<template>
  <v-app id="inspire">
    <appbar />
    <v-main>
      <v-container>
        
      </v-container>
    </v-main>
    <footbar />
  </v-app>
</template>


<script>
import appbar from '../components/Appbar.vue';
import footbar from '../components/InitialFooter.vue';

export default {
  components: { appbar, footbar }
  }
</script>