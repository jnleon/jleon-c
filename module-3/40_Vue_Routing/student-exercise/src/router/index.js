import Vue from 'vue';
import VueRouter from 'vue-router';
import BestSellerList from '@/views/Home'
import NewReleasesList from '@/views/Home'
import MyBooks from '@/views/MyBooks'
import AddBook from '@/views/NewBook.vue'
import BookDetails from '@/views/BookDetail.vue'

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'best-seller-list',
    component: BestSellerList
  },
  {
    path: '/',
    name: 'new-releases-list',
    component: NewReleasesList
  },
  {
    path: '/myBooks',
    name: 'my-books',
    component: MyBooks
  },
  {
    path: '/addBook',
    name: 'add-book',
    component: AddBook
  },
  {
    path: '/book/:isbn',
    name: 'book-details',
    component: BookDetails
  }
];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
