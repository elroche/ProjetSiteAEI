// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggleCollapse(colcont, button) {
    var x = document.getElementById(colcont);
    var btn = document.getElementById(button);
  
    if (x.style.display === "block") {
      x.style.display = "none";
      btn.innerHTML = "&#x2B9F;";
      btn.style.bottom = "-12px";
    } else {
      x.style.display = "block";
      btn.innerHTML = "&#x2B9D;";
      btn.style.bottom = "-12px";
    }
  }
  
  