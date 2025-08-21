// You can add your JavaScript code here to interact with your API.
console.log("app.js loaded");

// Sample data to populate the table
const sampleData = [
    { id: 1, first: 'Mark', last: 'Otto', handle: '@mdo' },
    { id: 2, first: 'Jacob', last: 'Thornton', handle: '@fat' },
    { id: 3, first: 'Larry', last: 'the Bird', handle: '@twitter' }
];

// Function to populate the table with data
function populateTable(data) {
    const tableBody = document.getElementById('api-data');
    tableBody.innerHTML = ''; // Clear existing data
    data.forEach(item => {
        const row = `<tr>
            <th scope="row">${item.id}</th>
            <td>${item.first}</td>
            <td>${item.last}</td>
            <td>${item.handle}</td>
        </tr>`;
        tableBody.innerHTML += row;
    });
}

// Populate the table with sample data on page load
document.addEventListener('DOMContentLoaded', () => {
    populateTable(sampleData);
});

// Example of how to fetch data from an API
/*
async function fetchData(url) {
    try {
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();
        populateTable(data);
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}

// Replace with your actual API endpoint
const apiUrl = 'https://api.example.com/data'; 
document.addEventListener('DOMContentLoaded', () => {
   fetchData(apiUrl);
});
*/

