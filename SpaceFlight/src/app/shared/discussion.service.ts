import { Injectable } from '@angular/core';
import { Discussion } from './discussion.model';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class DiscussionService {
  constructor(private http: HttpClient) {}

  formData: Discussion = new Discussion();
  readonly baseURL = 'http://localhost:5001/api/Discussion';

  postDiscussion() {
    return this.http.post(this.baseURL, this.formData);
  }
}
