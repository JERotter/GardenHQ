<template>
  <v-app>
    <appbar />
    <v-main class="main" >
      <v-container >
        <v-row>
          <v-col>

            <!-- Invite Request -->
            <div class="left-div">
              <v-card class="left-card"
              title="Request an Invitation Code"
              >
                <form @submit.prevent="submit">
                  <v-text-field
                    v-model="name.value.value"
                    :counter="10"
                    :error-messages="name.errorMessage.value"
                    label="First Name"
                  ></v-text-field>

                  <!-- <v-text-field
                    v-model="lastName.value.value"
                    :counter="10"
                    :error-messages="lastName.errorMessage.value"
                    label="LastName"
                  ></v-text-field> -->

                  <v-text-field
                    v-model="phone.value.value"
                    :counter="7"
                    :error-messages="phone.errorMessage.value"
                    label="Phone Number"
                  ></v-text-field>

                  <v-text-field
                    v-model="email.value.value"
                    :error-messages="email.errorMessage.value"
                    label="E-mail"
                  ></v-text-field>

                  <!-- <v-select
                    v-model="select.value.value"
                    :items="items"
                    :error-messages="select.errorMessage.value"
                    label="Select"
                  ></v-select> -->

                  <!-- <v-checkbox
                    v-model="checkbox.value.value"
                    :error-messages="checkbox.errorMessage.value"
                    value="1"
                    label="Option"
                    type="checkbox"
                  ></v-checkbox> -->
                  <v-btn class="me-4" type="submit"> Request Invite </v-btn>

                  <v-btn @click="handleReset"> clear </v-btn>
                </form>
              </v-card>
            </div>
          </v-col>

          <!-- Donate -->
          <v-col>
            <div class="right-div">
              <v-card class="right-card"
              title="Make a Donation! $">
                <form @submit.prevent="submit">
                  <v-text-field
                    v-model="name.value.value"
                    :counter="10"
                    :error-messages="name.errorMessage.value"
                    label="First Name"
                  ></v-text-field>

                  <v-text-field
                    v-model="phone.value.value"
                    :counter="7"
                    :error-messages="phone.errorMessage.value"
                    label="Phone Number"
                  ></v-text-field>

                  <v-text-field
                    v-model="email.value.value"
                    :error-messages="email.errorMessage.value"
                    label="E-mail"
                  ></v-text-field>

                  <v-select
                    v-model="select.value.value"
                    :items="items"
                    :error-messages="select.errorMessage.value"
                    label="Select Amount"
                  ></v-select>

                  <!-- <v-checkbox
                    v-model="checkbox.value.value"
                    :error-messages="checkbox.errorMessage.value"
                    value="1"
                    label="Option"
                    type="checkbox"
                  ></v-checkbox> -->
                  <v-btn class="me-4" type="submit"> submit </v-btn>

                  <v-btn @click="handleReset"> clear </v-btn>
                </form>
              </v-card>
            </div>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
    <footbar />
  </v-app>
</template>

<script>
import { ref } from "vue";
import { useField, useForm } from "vee-validate";
import appbar from "../components/Appbar.vue";
import footbar from "../components/InitialFooter.vue";

export default {
  components: { footbar, appbar },
  setup() {
    const { handleSubmit, handleReset } = useForm({
      validationSchema: {
        name(value) {
          if (value?.length >= 2) return true;

          return "Name needs to be at least 2 characters.";
        },
        phone(value) {
          if (value?.length > 9 && /[0-9-]+/.test(value)) return true;

          return "Phone number needs to be at least 9 digits.";
        },
        email(value) {
          if (/^[a-z.-]+@[a-z.-]+\.[a-z]+$/i.test(value)) return true;

          return "Must be a valid e-mail.";
        },
        select(value) {
          if (value) return true;

          return "Select an item.";
        },
        checkbox(value) {
          if (value === "1") return true;

          return "Must be checked.";
        },
      },
    });
    const name = useField("name");
    const phone = useField("phone");
    const email = useField("email");
    const select = useField("select");
    const checkbox = useField("checkbox");

    const items = ref(["$2", "$5", "$15", "$30"]);

    const submit = handleSubmit((values) => {
      alert(JSON.stringify(values, null, 2));
    });

    return { name, phone, email, select, checkbox, items, submit, handleReset };
  },
};
</script>

<style>
.left-card {
  padding: 25px;
}

.left-div {
  padding: 25px;
  background-color: #6f5e4f7e;
}

.right-card {
  padding: 25px;
}

.right-div {
  padding: 25px;
  background-color: #6f5e4f7e;
}

.main {
  padding: 20px;
  margin: 10px;
}

</style>