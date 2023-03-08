let situation1OpenSearch = document.getElementsByClassName("search")[0];

function openSearch() {
  if (situation1OpenSearch.style.display == "none") {
    document.getElementsByClassName("search")[0].style.display = "inline-block";
    document.getElementsByClassName("search")[1].style.display = "inline-block";
  } else {
    document.getElementsByClassName("search")[0].style.display = "none";
    document.getElementsByClassName("search")[1].style.display = "none";
  }
}
