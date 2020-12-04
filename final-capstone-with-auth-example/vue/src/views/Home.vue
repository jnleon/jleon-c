<template>
  <div class="home">
    <h1>Home</h1>
    <p>You must be authenticated to see this</p>
    <p>{{ greeting }}</p>
  </div>
</template>

<script>
import widgetService from "@/services/WidgetService.js";
export default {
  name: "home",
  data() {
    return {
      greeting: ''
    };
  },
  created() {
    widgetService
      .getWidget()
      .then((response) => {
        this.greeting = response.data;
      })
      .catch((error) => {
        let errorMessage = "uh oh";
        if (error.response) {
          errorMessage =
            "Error creating board. Response from server was " +
            error.response.statusText +
            ".";
        } else if (error.request) {
          errorMessage = "Error creating board. Could not reach server.";
        } else {
          errorMessage =
            "Error creating new board. Request could not be created.";
        }
        alert(errorMessage);
      });
  },
};
</script>
