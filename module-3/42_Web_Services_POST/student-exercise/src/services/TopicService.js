import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  list() {
    return http.get('/topics');
  },
  get(id) {
    return http.get(`/topics/${id}`);
  },
  addTopics(topic){
    return http.post('/topics',topic);
  },
  deleteTopics(topicID){
    return http.delete(`/topics/${topicID}`)
  },
  updateTopic(topic, topicID) {
    return http.put(`/topics/${topicID}`, topic);
  },
  }


