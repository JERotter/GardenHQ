<!-- https://github.com/BrianMwengi/vuenewsapi-app/tree/master/src -->
<!-- https://www.youtube.com/watch?v=lVr9ghYgrgU&list=PL046zjOZamPNQDJpjv8H5HFVI0PrrOlC4&index=2&ab_channel=WebDevTrainee -->

<template>
  <v-app id="inspire">
    <appbar />
    <v-main class="bg-brown-lighten-5">
      <v-container>
        <v-row>
          <v-col cols="12" sm="2">
            <v-sheet class="left-sheet" rounded="lg" min-height="268">
              <div class="letf-div">
                <h4>Resources</h4>
                <p>paragrphs</p>
              </div>
            </v-sheet>
          </v-col>

          <v-col cols="12" sm="8">
            <v-sheet class="news-sheet" min-height="70vh" rounded="lg">
              <div id="app">
                <News :apiKey="apiKey" />
              </div>
            </v-sheet>
          </v-col>

          <v-col cols="12" sm="2">
            <v-sheet class="right-sheet" rounded="lg" min-height="268">
              <h3>About</h3>
            </v-sheet>
          </v-col>
        </v-row>
      </v-container>
    </v-main>

    <footbar />
  </v-app>
</template>

<script>
import appbar from "../components/Appbar.vue";
import footbar from "../components/InitialFooter.vue";
import News from "../components/GardenNews.vue";

export default {
  name: 'app',
   data: () => {
     return {
       apiKey:'a60be4272ff046fb93e62cf4e8b13c22' //Get api key from newsapi.org
     }
   },
  components: { appbar, footbar, News },
};
</script>

<style lang="scss">
.left-sheet {
  padding: 25px;
  flex-direction: column;
  display: flex;
  justify-content: center;
}

.left-div {
  display: flex;
  flex-direction: column;
  /* justify-content: flex-start; */
  justify-content: center;
  align-items: center;
}

.right-sheet {
  padding: 25px;
  display: flex;
  justify-content: center;
}

.right-div {
  display: flex;
  flex-direction: column;
  /* justify-content: flex-start; */
  justify-content: flex-start;
}

.news-sheet {
  padding: 25px;
  display: flex;
  justify-content: center;
}

.news-div {
  display: flex;
  flex-direction: column;
  /* justify-content: flex-start; */
  justify-content: flex-start;
}

@import url('https://use.fontawesome.com/releases/v5.7.2/css/all.css');

body {
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    width: 100vw;
    height: 100vh;
    font-family: 'NTR', sans-serif;
    background: #eee;
}

#app {
  font-family: Arial, Helvetica, sans-serif;
  font-size: 1rem;
  color: #333;
  height: 100%;
  background-color: #fff;
  border: 2px solid #222;
  border-radius: 20px;
  box-shadow: 5px 10px 18px #222;
  overflow-y: scroll;
  overflow-x: hidden;
} 
  ::-webkit-scrollbar {
    display: none;
  }
</style>
