<template>
  <div class="main">
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>

    <div class="well-display">
      <div class="well">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <div class="well">
        <span class="amount">{{ numberOfOneStarReviews }}</span>
        1 Star Review {{ numberOfOneStarReviews === 1 ? "" : "s" }}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfTwoStarReviews }}</span>
        2 Star Review {{ numberOfTwoStarReviews === 1 ? "" : "s" }}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfThreeStarReviews }}</span>
        3 Star Review {{ numberOfThreeStarReviews === 1 ? "" : "s" }}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfFourStarReviews }}</span>
        4 Star Review {{ numberOfFourStarReviews === 1 ? "" : "s" }}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfFiveStarReviews }}</span>
        5 Star Review {{ numberOfFiveStarReviews === 1 ? "" : "s" }}
      </div>
    </div>

    <div class="review" v-for="r in reviews" v-bind:key="r.id" v-bind:class={favorited:r.favorited}>
      <h4>{{ r.reviewer }}</h4>
      <div class="rating">
        <img
          src="../assets/star.png"
          v-for="n in r.rating"
          v-bind:key="n"
          class="ratingStar"
          v-bind:title="r.rating"
        />
      </div>
      <h3>{{ r.title }}</h3>
      <p>{{ r.review }}</p>
      <p>Favorite? <input type="checkbox" v-model="r.favorited"/></p>
    </div>
  </div>
</template>

<script>
export default {
  name: "product-review",
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description:
        "Host and plan the eprfect cigar party for all your squirelly friends.",
      reviews: [
        {
          reviewer: "boom boom",
          title: "boom boom",
          review: "boom boom",
          rating: 1,
          id: 1,
          favorited: true,
        },
        {
          reviewer: "aaa aaa",
          title: "aaa aaa",
          review: "aaa aaa",
          rating: 2,
          id: 2,
          favorited: false,
        },
        {
          reviewer: "bbbb bbbb",
          title: "bbbb bbbb",
          review: "bbbb bbbb",
          rating: 3,
          id: 3,
          favorited: true,
        },
      ],
    };
  },
  computed: {
    averageRating() {
      //sum of all ratings divide
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);

      return sum / this.reviews.length;
    },
    numberOfOneStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        if (review.rating == 1) {
          return currentCount + 1;
        } else {
          return currentCount;
        }
      }, 0);
    },
    numberOfTwoStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        if (review.rating == 2) {
          return currentCount + 1;
        } else {
          return currentCount;
        }
      }, 0);
    },
    numberOfThreeStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        if (review.rating == 3) {
          return currentCount + 1;
        } else {
          return currentCount;
        }
      }, 0);
    },
    numberOfFourStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        if (review.rating == 4) {
          return currentCount + 1;
        } else {
          return currentCount;
        }
      }, 0);
    },
    numberOfFiveStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        if (review.rating == 5) {
          return currentCount + 1;
        } else {
          return currentCount;
        }
      }, 0);
    },
  },
};
</script>

<style scoped>
div.main {
  margin: 1rem 0;
}

div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}

div.main div.review.favorited {
  background-color: red;
}
</style>