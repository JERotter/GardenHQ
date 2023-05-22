// Utilities
import { defineStore } from "pinia";
import axios from "axios";

export const useTasksStore = defineStore("tasks", {
  state: () => ({
    tasks: [],
  }),
  actions: {
    fetchTasks: async function () {
      try {
        const response = await axios.get("https://localhost:7135/api/GardenTask/tasks");
        this.tasks = response.data.data;
      } catch (error) {
        alert(error);
        console.log(error);
      }
    },
     //https://www.youtube.com/watch?v=ixxSKJi4QXI&ab_channel=TheNetNinja api calls in pinia//options api//
    // addTask(tasks) {
    //   const res = await axios.post("https://localhost:7135/api/GardenTask/tasks")??
    // }
  },
});