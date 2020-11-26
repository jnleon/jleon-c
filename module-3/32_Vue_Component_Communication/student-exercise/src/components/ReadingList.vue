<template>
  <div class="book-container">

  <book-card v-for="bookie in $store.state.books" 
  v-bind:key="bookie.isbn" v-bind:book="bookie"
  ></book-card>

  </div>
</template>

<script>

import BookCard from "./BookCard";

export default {
    name: 'reading-list',
     components:{
        BookCard
    }
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>