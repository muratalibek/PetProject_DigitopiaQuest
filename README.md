# **Digitopia Quest**
<p>&nbsp;</p>

...This project represents the culminating endeavor of the course at **[iTransition Software Company](https://www.itransition.com)**. I have named this project "Digitopia Quest". Below, I will provide a detailed list of requirements along with my personal explanations for each step. Digitopia Quest is the web portal that provides reviews and recommendations for various types of entertainment such as books, movies, TV shows, and games. The portal should be designed to help users decide what to read, watch, play, and so on, based on the opinions of other users who have already experienced those forms of entertainment.
<p>&nbsp;</p>

1. Quotation from the assignment:
*"WEB PORTAL FOR REVIEWS "WHAT SHOULD U READ/WATCH/PLAY, etc.
Front: TypeScript/JavaScript, React, Node.js, MySQL/PostgreSQL/MongoDB, Bootstrap
.NET: C#/ASP.NET Core MVC/Entity Framework/SQL Server/MySQL/PostgreSQL, Bootstrap"*



>The development technologies for this project include both frontend and backend components. The backend requires .NET 7, while the frontend will utilize Bootstrap and Blazor. The database will be built using MSSQL.
<p>&nbsp;</p>

2. Quotation from the assignment:
*"Non-authenticated users have read-only access (they can use search, but can’t create reviews, can’t leave comments, rating and likes)."*

>As part of the course project for interns at a software company, the requirement is to limit the access of non-authenticated users to read-only mode. This means that they will be able to use the search function to look for specific reviews, but they will not be able to create reviews, leave comments, rate, or like any of the content on the platform.
<p>&nbsp;</p>

3. Quotation from the assignment:
>The project requirements specify that authenticated users who are not administrators will have access to all features of the web portal except for the admin-page. The admin-page will only provide a list of users with links to their individual user pages. Essentially, this means that regular users who have logged in will be able to create, edit, rate, and like reviews, leave comments, and access their own user pages, but they will not have access to any administrative functions.

<p>&nbsp;</p>

4. Quotation from the assignment:
*"It's necessary to suppot authentication via social networks (at least two)."*
>As part of the project requirements, the web portal must support authentication through at least two social networks. This means that users should be able to sign in to the platform using their existing social media accounts, such as Facebook or Twitter, instead of having to create a new account specifically for this portal.
<p>&nbsp;</p>

5. Quotation from the assignment:
*"Admin see every user page and review as its creator (e.g. admin can edit review or creates review under user from his/her page)."*
>As part of the project requirements, the administrator will have access to view every user page and review on the web portal. Additionally, the administrator will be able to edit reviews and create new reviews under the user's name from their respective pages. In essence, this means that the administrator will have complete control and access over all user-generated content on the platform.
<p>&nbsp;</p>

6. Quotation from the assignment:
*"Every page provides access to full-text search over whole app (results are represented as a review list, e.g., if some text is found in comment, the results page diplays link to the corresponding review page)."*
>As per the project requirements, every page of the web portal should have access to a full-text search function that searches the entire app for specific keywords or phrases. The search results will be displayed as a list of reviews, where each review will contain the searched keyword or phrase. If the keyword or phrase is found in a comment, the search results page will display a link to the corresponding review page. Essentially, this means that users can quickly and easily find specific reviews or comments that contain the information they are looking for.
<p>&nbsp;</p>

7. Quotation from the assignment:
*"Every user has a personal page, which contains table of the reviews (table should support filters, sorting, actions for review creation/deletion/editing/opening in a read mode)."*
>As per the project requirements, every user on the web portal will have their own personal page that will contain a table of their reviews. This table should be designed to support filters, sorting, and actions for review creation, deletion, editing, and opening in read mode. Essentially, this means that users will have easy access to their own reviews and will be able to manage them efficiently through their personal page. The table should be user-friendly and provide various options to make it easier for users to find, view, and edit their reviews.
<p>&nbsp;</p>

8. Quotation from the assignment:
*"Every review has: review name, name of the reviewed piece of art, "group" (from the fixed set: "Movies", "Books", "Games" и т.п.), tags (multiple tags with autocomplition - when users starts entering tag, dropdown show variants, which already exist in the app), review text обзора (with "markdown" formatting), optional image (stored in the cloud) and the grade in the range from 0 to 10."*
>s per the project requirements, every review on the web portal should have the following components: 
* Review name - a title or name given to the review by the user who created it
* Name of the reviewed piece of art - the name of the movie, book, game, or other type of media that the review is about
* Group - a category or genre from a fixed set of options such as "Movies", "Books", "Games", etc.
* Tags - multiple tags associated with the review, with an autocomplete feature that suggests previously used tags as the user begins typing.
* Review text - the actual review content, written by the user who created it and formatted with "markdown" formatting.
* Optional image - an image related to the reviewed piece of art, which is stored in the cloud.
* Grade - a rating given by the user who created the review, on a scale from 0 to 10.
>In essence, these components make up the structure and content of each review on the web portal.
<p>&nbsp;</p>

9. Quotation from the assignment:
*"All images are stored in the cloud, upload control should support drag-n-drop."*
>As per the project requirements, all images related to reviews on the web portal should be stored in the cloud. Additionally, the upload control for adding images should support drag-n-drop functionality. This means that users will be able to easily add images to their reviews by simply dragging and dropping them into the designated area. The use of a cloud-based storage solution ensures that the images will be accessible from anywhere and will not take up storage space on the user's device. Overall, this makes it easier and more convenient for users to add images to their reviews.