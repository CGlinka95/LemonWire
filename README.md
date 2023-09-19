# LemonWire
A little web app project to practice SQL statements, teach myself MySQL, and eventually listen to music. The title is just a small joke to reminisce about the old days of Limewire.

---

## Tech Stack
- C#
- .NET Core 6
- MAMP
- MySQL
- MySQL Workbench
- MySQL.Data
- NMewtonsoft.JSON

MAMP is a free and open-source collection of proprietary software used to manage a local web server/environment. The acronym stands for:
- **M**ac OS X as the operating system
- **A**pache 2 as web server software
- **M**ySQL as the database management system
- **P**HP as the script language (alternatively also Perl and Python)

With MAMP I was able to host my server locally to connect my database to my application in Microsoft Visual Studio. Once I had one table set up inside MAMP, I used MySQL Workbench to create a foreign key table from which I could further visualize and extend if I so chose.

---

## Screenshots

![Example of MAMP and the relational diagram from MySQL Workbench for LemonWire](https://github.com/CGlinka95/LemonWire/assets/77598170/5356eb83-bfa5-4a93-b02a-4951115c867c)
*Example of MAMP and the relational diagram from MySQL Workbench for LemonWire*

![Visual of the UI for LemonWire](https://github.com/CGlinka95/LemonWire/assets/77598170/30217f03-047a-47a1-9a8b-68f7e6ac667a)
*Visual of the UI for LemonWire*

---

## Current Version

In the current version of the application, the user can search for albums using full names or short phrases and characters. They can add albums to the database by supplying all of the required information, they can manually load the albums table to update the database on the UI. The tables load automatically when the application boots up as well and when selecting different album rows, the album cover art updates to it's respective album and shows any songs that stored in the database and associated with the selected album. Songs can also be deleted from the album and database.

## Later versions/TODO
- [ ] User can add songs to albums
- [ ] User can edit/update album and song information
- [ ] User can sort/reorder table columns when selecting them
- [ ] Add validation to all aspects of the application. Right now only delete song validation has been done
- [ ] User can delete entire albums, not just songs
- [ ] When selecting an album description or song lyrics cell in the respective columns, a separate window or box pops up so the user can read them
- [ ] Hide non-relevant table columns such as AlbumID and ImageURL
- [ ] Add a YouTube player (plugin?) so that when a song is selected, it will play
