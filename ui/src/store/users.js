// Utilities
import { defineStore } from "pinia";
import axios from "axios";

export const useUsersStore = defineStore("users", {
  state: () => ({
    users: [],
  }),
  actions: {
    fetchUsers: async function () {
      try {
        const response = await axios.get("https://localhost:7135/api/Users/Users");
        this.users = response.data.data;
      } catch (error) {
        alert(error);
        console.log(error);
      }
    },
    fetchUserProfile: async function () {
      try {
        const response = await axios.get("https://localhost:7135/api/Users/User-profile/018ea163-355e-454c-b6b0-02838f15f91d");
        this.users = response.data.data;
      } catch (error) {
        alert(error);
        console.log(error);
      }
    },
     //https://www.youtube.com/watch?v=ixxSKJi4QXI&ab_channel=TheNetNinja api calls in pinia//options api//
    // addUser(user) {
    //   const res = await axios.post('"https://localhost:7135/api/Users/Users"')
    //   const data = await res.json()
    // }
  },
});