<template>
  <v-app>
    <div class="main">
      <div class="appdiv">
        <appbar class="appbar" />
      </div>
      <div class="carousel-container">
        <v-carousel hide-delimiters="">
          <v-carousel-item
            v-for="(article, index) in articles"
            :key="index"
            @click="navTo(article.url)"
          >
            <div class="header">
              <img
                v-if="article.urlToImage"
                :src="article.urlToImage"
                alt="article.description"
              />
              <i v-else class="fas fa-image"></i>
            </div>
            <div class="article-details">
              <a :href="article.url" class="article-title">{{
                article.title
              }}</a>
            </div>
          </v-carousel-item>
        </v-carousel>

        <div class="about">
          <div class="about">
            <h1>About Garden HQ</h1>
            <p>
              Garden HQ is a comprehensive platform designed to empower
              organizers and community members in managing and nurturing
              community gardens. Our platform provides a centralized hub for all
              aspects of community garden organization, fundraising, resource
              management, and volunteer engagement.
            </p>
            <p>
              At Garden HQ, we understand the importance of community gardens as
              vibrant spaces that bring people together, promote sustainable
              practices, and enhance the well-being of neighborhoods. We aim to
              simplify the process of garden management, allowing organizers to
              focus on creating thriving green spaces and fostering community
              connections.
            </p>
            <h2>Features and Benefits</h2>
            <ul>
              <li>
                Organize and Manage: Garden HQ provides a user-friendly
                interface for administrators, managers, and volunteers to
                collaborate and streamline garden-related tasks. From plot
                assignments and event scheduling to inventory tracking and
                maintenance logs, Garden HQ simplifies the organizational
                process.
              </li>
              <li>
                Funds and Resources: With Garden HQ, organizers can explore
                funding opportunities and easily manage financial aspects of
                their community garden projects. Our platform connects you with
                potential donors, grants, and resources, ensuring sustainable
                growth and development.
              </li>
              <li>
                Education and Engagement: Garden HQ believes in the power of
                knowledge sharing. Our platform offers educational resources,
                articles, and forums to inspire and inform gardeners of all
                levels. Connect with like-minded individuals, share insights,
                and learn from experienced community garden enthusiasts.
              </li>
              <li>
                Volunteer Network: Garden HQ makes it effortless to connect with
                passionate individuals looking to contribute their time and
                skills to community gardens. Volunteers can discover nearby
                projects, sign up for shifts, and stay engaged in meaningful
                gardening activities.
              </li>
            </ul>
            <p>
              Whether you're an administrator overseeing multiple community
              gardens, a manager responsible for day-to-day operations, or a
              volunteer eager to make a difference, Garden HQ provides the tools
              and support you need to create successful and thriving community
              garden spaces.
            </p>
          </div>
        </div>

        <div class="resources">
          <h1>Resources</h1>
          <p>
            Lorem ipsum dolor & cheddar! sit amet consectetur adipisicing elit.
            Sapiente vel mollitia totam eius illum dolor asperiores maiores
            voluptates inventore consequuntur sed commodi blanditiis, repellat
            vitae, saepe harum quos, dicta error! Lorem ipsum dolor sit amet
            consectetur adipisicing elit. Sapiente vel mollitia totam eius illum
            dolor asperiores maiores voluptates inventore consequuntur sed
            commodi blanditiis, repellat vitae, saepe harum quos, dicta error!
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente
            vel mollitia totam eius illum dolor asperiores maiores voluptates
            inventore consequuntur sed commodi blanditiis, repellat vitae, saepe
            harum quos, dicta error! Lorem ipsum dolor sit amet consectetur
            adipisicing elit. Sapiente vel mollitia totam eius illum dolor
            asperiores maiores voluptates inventore consequuntur sed commodi
            blanditiis, repellat vitae, saepe harum quos, dicta error! Lorem
            ipsum dolor sit amet consectetur adipisicing elit. Sapiente vel
            mollitia totam eius illum dolor asperiores maiores voluptates
            inventore consequuntur sed commodi blanditiis, repellat vitae, saepe
            harum quos, dicta error! Lorem ipsum dolor sit amet consectetur
            adipisicing elit. Sapiente vel mollitia totam eius illum dolor
            asperiores maiores voluptates inventore consequuntur sed commodi
            blanditiis, repellat vitae, saepe harum quos, dicta error! Lorem
            ipsum dolor sit amet consectetur adipisicing elit. Sapiente vel
            mollitia totam eius illum dolor asperiores maiores voluptates
            inventore consequuntur sed commodi blanditiis, repellat vitae, saepe
            harum quos, dicta error!
          </p>
        </div>
        <footbar />
      </div>
    </div>
  </v-app>
</template>

<script>
import axios from "axios";
import appbar from "../components/Appbar.vue";
import footbar from "../components/InitialFooter.vue";

export default {
  name: "app",
  data() {
    return {
      articles: [],
    };
  },
  mounted() {
    this.fetchNewsArticles();
  },
  components: { appbar, footbar },
  methods: {
    fetchNewsArticles() {
      const apiKey = "a60be4272ff046fb93e62cf4e8b13c22";
      const pageSize = 7;
      const url = `https://newsapi.org/v2/everything?q=gardening&q=nature&pageSize=${pageSize}&apiKey=${apiKey}`;

      axios
        .get(url)
        .then((response) => {
          this.articles = response.data.articles;
        })
        .catch((error) => {
          console.error("Error fetching news articles:", error);
        });
    },
  },
};
</script>

<style lang="scss" scoped>
.appdiv {
  display: flex;
}

.main {
  position: relative;
  z-index: 1;
}

.appbar {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  z-index: 1000;
}

.carousel-container {
  margin-top: 64px;
  padding: 20px;
}

.header {
  margin-top: 64px;
  display: flex;
  flex-direction: column;
  width: 100%;
  justify-content: center;
  align-items: center;
  overflow: hidden;
  margin-bottom: 10px;
}

.header img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.v-responsive__content:is(div:not(:empty)) {
  position: relative;
  z-index: 1;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.article-details {
  position: absolute;
  margin-top: 10px;
  bottom: 0;
  left: 0;
  right: 0;
  padding: 10px;
  height: 100px;
  background-color: rgba(0, 0, 0, 0.7);
  color: white;
  display: flex;
  align-items: center;
  justify-content: center;
}

.article-title {
  color: white;
  font-size: 18px;
}
.about {
  position: relative;
  z-index: 0;
  padding: 20px;
}
.resources {
  padding: 20px;
}
</style>
