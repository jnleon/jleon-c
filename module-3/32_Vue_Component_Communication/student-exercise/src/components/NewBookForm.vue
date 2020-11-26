<template>
<form class= "new-book-form" v-on:submit.prevent="addBookMEOW">

<label for= "title-input">Book Title: </label>
<input class = "title-input" type="text" v-model="newBook.title">

<label for= "author-input" >Book Author: </label>
<input class = "author-input" type="text" v-model="newBook.author">


<label for= "isbn-input">Book ISBN: </label>
<input class = "isbn-input" type="text" v-model="newBook.isbn">

<input type="submit" >

      </form>
</template>

<script>
export default {
    name: "add-book",
data() {
return {
newBook: {
title: '',
author: '',
isbn: '',
read: false
},
};
},
methods: {
    addBookMEOW(){
        this.$store.commit("NEW_BOOK", this.newBook)
        this.newBook={};
    }}}
    
</script>

<style>

</style>