import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  get(id) {
    return http.get(`/messages/${id}`);
  },
  updateMessage(message, messageID) {
    return http.put(`/messages/${messageID}`, message);
  },
  deleteMessage(messageID) {
    return http.delete(`/messages/${messageID}`);
  },
  addMessage(message){
    return http.post('/messages',message);
  },

}
