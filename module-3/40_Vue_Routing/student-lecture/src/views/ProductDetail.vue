<template>
    <div>
        <h1>{{product.name}}</h1>
        <p class="description">{{product.description}}</p>
         <div class="well-display">
      <average-summary />
      <star-summary rating="1" />
      <star-summary rating="2" />
      <star-summary rating="3" />
      <star-summary rating="4" />
      <star-summary rating="5" />
      <review-list/>
    </div>

</template>
<script>
export default {
    
    created(){
        const activeProductID= this.$route.params.id;
        this.$store.commit('SET_ACTIVE_PRODUCT', activeProductID)
    },
    computed:{
        product(){
           return this.$store.state.products.find(p => p.id ==this.$store.state.activeProduct);

        }

    }

}
</script>

<style>

</style>