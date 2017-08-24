var search = instantsearch({
  // Replace with your own values
    appId: 'H32KJL7TN3',
  apiKey: '0c72100e179fa5222d6fe396674514d7', // search only API key, no ADMIN key
  indexName: 'product',
  urlSync: true
});

search.addWidget(
  instantsearch.widgets.searchBox({
    container: '#search-input'
  })
);

search.addWidget(
  instantsearch.widgets.hits({
    container: '#hits',
    hitsPerPage: 10,
    templates: {
      item: document.getElementById('hit-template').innerHTML,
      empty: "We didn't find any results for the search <em>\"{{query}}\"</em>"
    }
  })
);

search.start();