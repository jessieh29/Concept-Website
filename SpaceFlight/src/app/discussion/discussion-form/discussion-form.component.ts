import { Component, OnInit } from '@angular/core';
import { DiscussionService } from 'src/app/shared/discussion.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-discussion-form',
  templateUrl: './discussion-form.component.html',
  styles: [],
})
export class DiscussionFormComponent implements OnInit {
  constructor(public service: DiscussionService) {}

  ngOnInit(): void {}

  onSubmit(form: NgForm) {
    this.service.postDiscussion().subscribe(
      (res) => {},
      (err) => {
        console.log(err);
      }
    );
  }
}
