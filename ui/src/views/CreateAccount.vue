<template>
  <v-app>
    <appbar />
    <v-main class="main">
      <v-container>
        <v-row>
          <v-col>
            <div class="left-div">
              <v-card class="left-card" title="Create Your Account">
                <form @submit.prevent="submit">
                  <v-text-field
                    v-model="invitationCode.value.value"
                    :counter="10"
                    :error-messages="invitationCode.errorMessage.value"
                    label="Invitation Code"
                  ></v-text-field>

                  <v-text-field
                    v-model="firstName.value.value"
                    :counter="10"
                    :error-messages="firstName.errorMessage.value"
                    label="First Name"
                  ></v-text-field>

                  <v-text-field
                    v-model="lastName.value.value"
                    :counter="10"
                    :error-messages="lastName.errorMessage.value"
                    label="Last Name"
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

                  <v-text-field
                    v-model="streetAddress.value.value"
                    :counter="10"
                    :error-messages="streetAddress.errorMessage.value"
                    label="Street Address"
                  ></v-text-field>

                  <v-text-field
                    v-model="streetAddressLine2.value.value"
                    :counter="10"
                    :error-messages="streetAddressLine2.errorMessage.value"
                    label="Street Address Line2"
                  ></v-text-field>

                  <v-text-field
                    v-model="city.value.value"
                    :counter="10"
                    :error-messages="city.errorMessage.value"
                    label="City"
                  ></v-text-field>

                  <v-text-field
                    v-model="state.value.value"
                    :counter="10"
                    :error-messages="state.errorMessage.value"
                    label="state"
                  ></v-text-field>

                  <v-text-field
                    v-model="country.value.value"
                    :counter="10"
                    :error-messages="country.errorMessage.value"
                    label="Country"
                  ></v-text-field>

                  <v-text-field
                    v-model="zipCode.value.value"
                    :counter="10"
                    :error-messages="zipCode.errorMessage.value"
                    label="Zip"
                  ></v-text-field>

                  <v-btn class="me-4" type="submit"> Submit </v-btn>
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
// import { ref } from "vue";
import { useField, useForm } from "vee-validate";
import appbar from "../components/Appbar.vue";
import footbar from "../components/CreateFooter.vue";

export default {
  components: { footbar, appbar },
  setup() {
    const { handleSubmit, handleReset } = useForm({
      validationSchema: {
        invitationCode(value) {
          if (value?.length >= 2) return true;

          return "Name needs to be at least 2 characters.";
        },
        firstName(value) {
          if (value?.length >= 2) return true;

          return "Name needs to be at least 2 characters.";
        },
        lastName(value) {
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
        streetAddress(value) {
          if (value?.length >= 2) return true;

          return "streetAddress needs to be at least 2 characters.";
        },
        streetAddressLine2(value) {
          if (value?.length >= 2) return true;

          return "Name needs to be at least 2 characters.";
        },
        city(value) {
          if (value?.length >= 2) return true;

          return "City needs to be at least 2 characters.";
        },
        state(value) {
          if (value?.length >= 2) return true;

          return "state needs to be at least 2 characters.";
        },
        country(value) {
          if (value?.length >= 2) return true;

          return "Country needs to be at least 2 characters.";
        },
        zipCode(value) {
          if (value?.length >= 2) return true;

          return "Zip code needs to be at least 2 characters.";
        },
      },
    });
    const invitationCode = useField("invitationCode");
    const firstName = useField("firstName");
    const lastName = useField("lastName");
    const phone = useField("phone");
    const email = useField("email");
    const streetAddress = useField("streetAddress");
    const streetAddressLine2 = useField("streetAddressLine2");
    const city = useField("city");
    const state = useField("state");
    const country = useField("country");
    const zipCode = useField("zipCode");

    const submit = handleSubmit((values) => {
      alert(JSON.stringify(values, null, 2));
    });

    return {
      invitationCode,
      firstName,
      lastName,
      phone,
      email,
      streetAddress,
      streetAddressLine2,
      city,
      state,
      country,
      zipCode,
      submit,
      handleReset,
    };
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
