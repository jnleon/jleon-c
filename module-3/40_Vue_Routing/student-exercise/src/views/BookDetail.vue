<template>
  <book-details v-bind:book="book"/>
</template>

<script>
import BookDetails from '../components/BookDetails.vue'

export default {
created(){
    let selectedBook = this.$store.state.books.find((book) => book.isbn == this.$route.params.isbn);
    this.$store.commit('SET_ACTIVE_BOOK', selectedBook)
},
computed:{
    book(){
        return this.$store.state.books.find(
            (b)=> b.isbn == this.$store.state.selectedBook
        );
    },
},
components: 
 { 
 BookDetails 
 },
}
</script>

<style>

</style>