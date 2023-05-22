// Utilities
// https://www.youtube.com/watch?v=T2b5U9USulc&ab_channel=CodeWithTony
//https://www.youtube.com/watch?v=G4H6QOcGKbU&ab_channel=Bitfumes  getters for full name//
import { defineStore } from "pinia";
import axios from "axios";

export const useUsersStore = defineStore("users", {
  state: () => ({
    users: [],
  }),
  actions: {
    async fetchUsers() {
      try {
        await axios.get("https://localhost:7135/api/Users/Users").then((res) => {
        this.users = res.data;
        })
      }
        catch (error) {
          alert(error)
          console.log(error)
        }
      }
    },
    //https://www.youtube.com/watch?v=ixxSKJi4QXI&ab_channel=TheNetNinja api calls in pinia//options api//
    // addUser(user) {
    //   const res = await axios.post('"https://localhost:7135/api/Users/Users"')
    //   const data = await res.json()
    // }
  });
