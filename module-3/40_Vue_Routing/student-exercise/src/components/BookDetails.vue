<template>
  <book-card v-bind:book="book"/>
</template>

<script>
import BookCard from './BookCard.vue'
export default {
components:{
  BookCard
},
props:['book']
}
</script>

<style>

</style>