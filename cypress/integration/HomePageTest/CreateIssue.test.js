/// <reference types="Cypress" />

describe('Click create Issue button ' , () => {
    beforeEach(() => {
        cy.visit('https://localhost:44322/')
    })
    
   
    it('Check create Issue button link work' , () => {
        
       
        cy.get('[data-cy=createIssueBtn]').should('exist').click()

        // new url
        cy.url().should('include','CreateIssue' )
        
        
        // looks if everything that I want on the site is there
        cy.get('[data-cy=summary]').should('exist')
        cy.get('[data-cy=description]').should('exist')
      
        cy.contains('Priority').should('exist')
        cy.contains('Add summary').should('exist')

        
        // goes back to home page
        cy.go('back')

        cy.get('[data-cy=createIssueBtn]').should('exist')

      
      
        
    })


  

    it.only('Create issue should display right error and then write right ' , () => {

      
        cy.get('[data-cy=createIssueBtn]').should('exist').click()
        //before button click error should be empty
        
         cy.url().should('include', '/CreateIssue')

        cy.contains('Please choose a priority').should('not.exist')
        cy.contains("Summary can't be empty").should('not.exist')
     
        cy.get('[data-cy=addSummaryBtn]').click()
        
    
        //after click button should display error
        
        cy.contains('Please choose a priority').should('exist')
        cy.contains("Summary can't be empty").should('exist')
      
        //kollar om jag är på rätt ställe
        
        cy.get('[data-cy=summary]').type('Test')
        cy.get('[data-cy=priority]').select('Medium')

     
    
        cy.get('[data-cy=addSummaryBtn]').click()
        cy.contains('Please choose a priority').should('not.exist')
        cy.contains("Summary can't be empty").should('not.exist')
        

})

    


   
       

})


// should('have.text', 'Create Issue')
// cy.viewport(1280,720)
//it.only runs only that test
// cy.get('[data-cy=summary]').type('Yey')
//cy.url().should('include', '/CreateIssue')
// cy.pause()