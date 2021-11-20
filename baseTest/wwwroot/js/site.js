// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let app = new Vue({
    el: '#app',
    data() {
        return {
            tickets: null
        };
    },
    mounted() {
        axios
            .get('https://localhost:44360/getTickets')
            .then(response => (this.tickets = response.data));
    }
})