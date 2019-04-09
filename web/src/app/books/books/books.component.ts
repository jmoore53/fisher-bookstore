import { Component, OnInit, Injectable } from '@angular/core';
import { Book } from '../book';
import { BooksService } from '../books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  public BookService: BooksService;
  /* books: Book[] = [
    {
      id: 1,
      title: 'Ready Player One',
      author: 'Ernest Cline'
    },
    {
      id: 2,
      title: 'Catch 22',
      author: 'Joseph Heller'
    }
  ];
  */

  books = this.BookService.getBooks();

  constructor() {
  }

  ngOnInit() {
  }
}
