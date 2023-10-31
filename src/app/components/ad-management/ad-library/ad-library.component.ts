import { Component } from '@angular/core';
import { AdFiltersComponent } from "../ad-filters/ad-filters.component";
import { AdSnippetComponent } from "../ad-snippet/ad-snippet.component";

@Component({
    selector: 'app-ad-library',
    standalone: true,
    templateUrl: './ad-library.component.html',
    styleUrls: ['./ad-library.component.scss'],
    imports: [AdFiltersComponent, AdSnippetComponent]
})
export class AdLibraryComponent {

}
