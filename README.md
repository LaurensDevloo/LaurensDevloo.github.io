# Laurens Devloo
<div class="accordion" id="accordionExample">
  <div class="accordion-item">
    <h2 class="accordion-header" id="headingOne">
      <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
        Alemene informatio
      </button>
    </h2>
    <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <img src="Eportfolio/wwwroot/img/Laurens_Devloo.png" style="width: 15%; float:right"/>
        <div class="half-page-left">
        <p>
            Ik ben @Model.FirstName @Model.Name en ben een backend developers met een grote interesse data engineering .<br />
            Ik ben geboren op @Model.BirthDay.ToShortDateString() en ben dus @Model.BerekenLeeftijd() jaar oud. <br />
            U kunt me altijd bereiken op <br />mijn vaste telefoon: <strong>@Model.TelephoneNumber</strong><br />
            of mijn GSM: <strong>@Model.CellNumber</strong>.
            Schriftelijk contact is mogelijk via ofwel email op <a href="mailto: @Model.Email">@Model.Email</a>
            ofwel via op mijn thuisadres @Model.Address, @Model.Postcode @Model.City.
        </p>
        <p><iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d2514.5039267814063!2d4.030175!3d50.932893!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c3bd5028aa16e5%3A0x368d57400e5dc9ce!2sSint%20Jobstraat%20144%2C%209300%20Aalst!5e0!3m2!1snl!2sbe!4v1615837784036!5m2!1snl!2sbe" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe></p>
    </div>
    <div class="half-page-right">
        <h2>Een beter inzicht in Laurens Devloo</h2>
        <ul class="list-group">
            <li class="list-group-item"><a asp-action="CV">Mijn CV</a></li>
            <li class="list-group-item"><a asp-action="MBTI">MBTI: Wat voor persoon ben ik</a></li>
            <li class="list-group-item"><a asp-action="Offman">Ofman</a></li>
            <li class="list-group-item"><a asp-action="Realisaties">Gerealiseerde projecten</a></li>
            <li class="list-group-item"><a asp-action="Talen">In de huidige wereld kan men niet zonder talen, hierbij de voorlopige lijst</a></li>
            <li class="list-group-item"><a asp-action="ProgrammeerTalen">De programmertalen waarmee ik kan werken.</a></li>
            <li class="list-group-item"><a asp-action="WerkErvaring">Mijn voorgaande werkervaring</a></li>
        </ul>
    </div>
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header" id="headingTwo">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
        Accordion Item #2
      </button>
    </h2>
    <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <strong>This is the second item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header" id="headingThree">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
        Accordion Item #3
      </button>
    </h2>
    <div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        <strong>This is the third item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
</div>