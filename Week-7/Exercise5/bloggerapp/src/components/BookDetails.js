import { books } from '../data/books';

function BookDetails() {
  const bookdet = (
    <ul>
      {books.map((book) => (
        <div key={book.id}>
          <h3>{book.bname}</h3>
          <h4>{book.price}</h4>
        </div>
      ))}
    </ul>
  );

  return (
    <div>
      <h1>Book Details</h1>
      {bookdet}
    </div>
  );
}

export default BookDetails;