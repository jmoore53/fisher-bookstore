import { Component, OnInit, Injectable } from '@angular/core';
import { Book } from '../book';
import { BooksService } from '../books.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  /*
  books: Book[] = [
    {
      Id: 1,
      Title: 'Ready Player One',
      Author: 'Ernest Cline',
      Isbn: "string",
      PublishDate: "object",
      Publisher: "string"
    },
    {
      Id: 2,
      Title: 'Ready Player One',
      Author: 'Ernest Cline',
      Isbn: "string",
      PublishDate: "object",
      Publisher: "string"
    },
  ];
  */
  books: Book[];

  constructor(private bookService: BooksService){}

  fetchBooks(){
    this.bookService.getBooks().subscribe(books => (this.books = books));
    console.log(this.books)
  }


  ngOnInit() {
    this.fetchBooks();
  }
}
