import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  private isMan: boolean = true;
  private tablica: string[] = ["pierwszy", "drugi", "trzeci"];
  private wybranyTemat: string = "";

  constructor() { }

  ngOnInit() {
  }

  sprawdz(): void {

    alert(this.wybranyTemat);

  }

}
