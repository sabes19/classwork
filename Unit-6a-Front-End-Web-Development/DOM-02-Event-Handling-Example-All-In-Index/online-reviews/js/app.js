const productName = "Quark's Bar";
const description = 'Located in Deep Space 9, near Bajor in the Alpha Quadrant';
const reviews = [
  {
    reviewer: 'Marcus Aurilious',
    title: 'Better have a lot of latinum!',
    review:
      "About what you would expect on a space station.  VERY expensive",
    rating: 3
  },
  {
    reviewer: 'Morg',
    title: 'My favorite place in the Alpha Quadrant',
    review:
      "I am a regular at this place an love it!",
    rating: 5
  },
  {
    reviewer: 'Garak',
    title: 'Ferengi owned - you know what that means! Premium prices, low quality',
    review:
      "Can't trust the Ferengi.  Gaming Room is fixed, no one wins.  Dabo girls will rob you blind.  Holosuites substandard.",
    rating: 1
  },
  {
    reviewer: 'Nog',
    title: 'Uncle Quark is a great host!',
    review:
      "Patrons seem to enjoy themselves and love my Uncle Quark.  He is bit hard on me though",
    rating: 4
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerHTML = productName;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerHTML = description;
}

/**
 * I will display all of the reviews in the reviews array
 */
function displayReviews() {  
    // if there is a template in the HTML - use it to add to the dom
    // This will create HTML on the template in the HTML
  if ('content' in document.createElement('template')) {
    //Loop through array elements
    reviews.forEach((review) => {
      displayReview(review);
    });
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 *
 * @param {Object} review The review to display
 */
function displayReview(review) {
    //get a ref to the main main div
  const main = document.getElementById('main');
    // get a ref to a copy of the template defined in the main div
  const tmpl = document.getElementById('review-template').content.cloneNode(true);
  tmpl.querySelector('h4').innerHTML = review.reviewer;
  tmpl.querySelector('h3').innerHTML = review.title;
  tmpl.querySelector('p').innerHTML = review.review;
  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = tmpl.querySelector('img').cloneNode();
    tmpl.querySelector('.rating').appendChild(img);
  }
  main.appendChild(tmpl);
}

// LECTURE STARTS HERE ---------------------------------------------------------------

// Any time a user interacts with a web page an event is generated
// an EVENT is a user interaction with a web page or a point in the life of the web page
// hook - place yhou can interact based on a hook

// we tell the browser to listen for an event for a particular event and let us process it
// .addEventListener() is how you tell the browser which events you want to process
// you provide an anonymous method to process the event (named method may also be suitable

// when the DOM is created by the browser (DOMContentLoaded event) run the 3 functions we have to set up the page

document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  setPageDescription();
  displayReviews();

  // When a user clicks on the description show input box
  const desc = document.querySelector('.description');
  desc.addEventListener('click', (event) => {
    toggleDescriptionEdit(event.target);
  });

  const inputDesc = document.getElementById('inputDesc');
  inputDesc.addEventListener('keyup', (event) => {
    if (event.key === 'Enter') {
      exitDescriptionEdit(event.target, true);
    }
    if (event.key === 'Escape') {
      exitDescriptionEdit(event.target, false);
    }
  });

  inputDesc.addEventListener('mouseleave', (event) => {
    exitDescriptionEdit(event.target, false);
  });

  // Show/Hide the Add Review Form
  const btnToggleForm = document.getElementById('btnToggleForm');
  btnToggleForm.addEventListener('click', () => {
    showHideForm();
  });

  // save the review and display it
  const btnSaveReview = document.getElementById('btnSaveReview');
  btnSaveReview.addEventListener('click', (event) => {
    event.preventDefault();
    saveReview();
  });
});

/**
 * Take an event on the description and swap out the description for a text box.
 *
 * @param {Event} event the event object
 */
function toggleDescriptionEdit(desc) {
  const textBox = desc.nextElementSibling;
  textBox.value = description;
  textBox.classList.remove('d-none');
  desc.classList.add('d-none');
  textBox.focus();
}

/**
 * Take an event on the text box and set the description to the contents
 * of the text box and then hide the text box and show the description.
 *
 * @param {Event} event the event object
 * @param {Boolean} save should we save the description text
 */
function exitDescriptionEdit(textBox, save) {
  let desc = textBox.previousElementSibling;
  if (save) {
    desc.innerText = textBox.value;
  }
  textBox.classList.add('d-none');
  desc.classList.remove('d-none');
}

/**
 * I will show / hide the add review form
 */
function showHideForm() {
  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  if (form.classList.contains('d-none')) {
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } else {
    resetFormValues();
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * I will reset all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

/**
 * I will save the review that was added using the add review from
 */
function saveReview() {
  const name = document.getElementById('name');
  const title = document.getElementById('title');
  const review = document.getElementById('review');
  const rating = document.getElementById('rating');

  const newReview = {
    reviewer: name.value,
    title: title.value,
    review: review.value,
    rating: rating.value
  };
  reviews.push(newReview);
  displayReview(newReview);
  showHideForm();
}
